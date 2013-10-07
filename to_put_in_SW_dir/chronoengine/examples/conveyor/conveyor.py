#-------------------------------------------------------------------------------
# Name:        conveyor
#
# This file shows how to
#   - create a stack of pebbles
#
#-------------------------------------------------------------------------------
#!/usr/bin/env python

def main():
    pass

if __name__ == '__main__':
    main()


# Load the Chrono::Engine unit and the postprocessing unit!!!
import ChronoEngine_PYTHON_core as chrono
import ChronoEngine_PYTHON_postprocess as postprocess
import os
import imp
import math
import matplotlib
import csv
import random
import numpy as np
import matplotlib.cm as cm
import matplotlib.mlab as mlab
import matplotlib.pyplot as plt
import sys

#from PyQt4 import QtGui, QtCore


# Create a physical system,
my_system = chrono.ChSystem()


# Set the default outward/inward shape margins for collision detection,
# this is epecially important for very large or very small objects.
chrono.ChCollisionModel.SetDefaultSuggestedEnvelope(0.005)
chrono.ChCollisionModel.SetDefaultSuggestedMargin(0.005)



# Load the CAD file

exported_items = chrono.ImportSolidWorksSystem('cad_conveyor')


# Add items to the physical system
my_system = chrono.ChSystem()
for my_item in exported_items:
    my_system.Add(my_item)






# Create a contact material (surface property)to share between all objects.
# The rolling and spinning parameters are optional - if enabled they double
# the computational time.
pebble_material = chrono.ChMaterialSurfaceShared()
pebble_material.SetFriction(0.6)
#pebble_material.SetDampingF(0.1)
#pebble_material.SetCompliance (0.0000000001)
#pebble_material.SetComplianceT(0.0000000001)
pebble_material.SetRollingFriction(0.005)
pebble_material.SetSpinningFriction(0.005)
# pebble_material.SetComplianceRolling(0.0000001)
# pebble_material.SetComplianceSpinning(0.0000001)


# Assign the surface moaterial also to items made with CAD:
my_item = my_system.Search('floor_box^assembly_conveyor-1')
my_floor  = chrono.CastToChBodyAuxRefShared(my_item)
if my_floor.IsNull() :
    sys.exit('Error: cannot find floor_box from its name in the C::E system!')
my_bodyfloor  = chrono.CastToChBodyAuxRefShared(my_floor)
if not my_bodyfloor.IsNull() :
    my_bodyfloor.SetMaterialSurface(pebble_material)
else :
    sys.exit('Error: cannot assign material to floor_box!')




# Create the pebbles

density_pebble = 2028;    # kg/m^3
diameter_pebble = 0.045

mass_pebble = density_pebble * (4./3.) * chrono.CH_C_PI * pow((diameter_pebble*0.5),3)
inertia_pebble = (2./5.)*mass_pebble*(pow((diameter_pebble*0.5),2))



pebbles = chrono.ChParticlesClonedShared()

pebbles.SetMass(mass_pebble)
pebbles.SetInertiaXX(chrono.ChVectorD(inertia_pebble,inertia_pebble,inertia_pebble))
pebbles.SetMaterialSurface(pebble_material)

pebbles.GetCollisionModel().ClearModel()
pebbles.GetCollisionModel().AddSphere(diameter_pebble/2.)
pebbles.GetCollisionModel().BuildModel()
pebbles.SetCollide(True)

pebbles_shape = chrono.ChSphereShapeShared()
pebbles_shape.GetSphereGeometry().rad = diameter_pebble/2.
pebbles.GetAssets().push_back(pebbles_shape)
my_system.Add(pebbles)

max_pebbles = 1000
created_pebbles = 0
n_outlet_x = 5
n_outlet_z = 5
size_outlet_x = 0.28
size_outlet_z = 0.28
#pos_outlet = chrono.ChVectorD(0,1.0,0)  # to drop stuff directly on vertical
pos_outlet = chrono.ChVectorD(-2,1.6,0)  # to drop stuff into the hopper



# Create the conveyor belt
conv_length = 2.5
conv_thick = 0.1
conv_width = 0.38
body_belt = chrono.ChConveyorShared(conv_length,conv_thick,conv_width)
body_belt.SetBodyFixed(True)
body_belt.SetConveyorSpeed(0.5)  # m/s

# set the position of the conveyor as in a CAD reference coordsys
my_marker = my_system.SearchMarker('Sistema di coordinate1')
if my_marker.IsNull() :
    sys.exit('Error: cannot find marker from its name in the C::E system!')
body_belt.SetCoord(my_marker.GetAbsCoord())

# note: the CAD reference was on surface, so we must move down COG that is at middle of surface:
body_belt.ConcatenatePreTransformation(chrono.ChFrameMovingD(chrono.ChVectorD(0, -0.005-conv_thick/2., 0)))


my_system.Add(body_belt)





# Create the room floor: a simple fixed rigid body with a collision shape
# and a visualization shape

body_floor = chrono.ChBodyShared()
body_floor.SetBodyFixed(True)
body_floor.SetPos(chrono.ChVectorD(0, -1, 0 ))
body_floor.SetMaterialSurface(pebble_material)

# Collision shape (shared by all particle clones)
body_floor.GetCollisionModel().ClearModel()
body_floor.GetCollisionModel().AddBox(3, 1, 3) # hemi sizes
body_floor.GetCollisionModel().BuildModel()
body_floor.SetCollide(True)

# Visualization shape (shared by all particle clones)
body_floor_shape = chrono.ChBoxShapeShared()
body_floor_shape.GetBoxGeometry().Size = chrono.ChVectorD(3, 1, 3)
body_floor.GetAssets().push_back(body_floor_shape)
body_floor_texture = chrono.ChTextureShared()
body_floor_texture.SetTextureFilename('concrete.jpeg')
body_floor.GetAssets().push_back(body_floor_texture)

my_system.Add(body_floor)








#  Since we want to render a short animation by generating scripts
#  to be used with POV-Ray, a ChPovRay postprocessing tool must be created
#  and some parameters to be set..

pov_exporter = postprocess.ChPovRay(my_system)

 # Sets some file names for in-out processes.
pov_exporter.SetTemplateFile        ("_template_POV.pov")
pov_exporter.SetOutputScriptFile    ("rendering_frames.pov")
if not os.path.exists("output"):
    os.mkdir("output")
if not os.path.exists("anim"):
    os.mkdir("anim")
pov_exporter.SetOutputDataFilebase("output/my_state")
pov_exporter.SetPictureFilebase("anim/picture")

pov_exporter.SetCamera(chrono.ChVectorD(4.2,2.5,4.5), chrono.ChVectorD(0,0.5,0), 32)
pov_exporter.SetLight(chrono.ChVectorD(-2,4,-1), chrono.ChColor(0.5,0.5,0.6), 0)
pov_exporter.SetPictureSize(640,480)
pov_exporter.SetAmbientLight(chrono.ChColor(2,2,2))

 # Add additional POV objects/lights/materials in the following way
pov_exporter.SetCustomPOVcommandsScript(
'''
light_source{ <1,4,1.5> color rgb<1.0,1.0,1.0> }
//object{ Grid(0.5,0.04, rgb<0.5,0.5,0.5>, rgbt<1,1,1,1>) rotate <0,0,90> }
''')

 # Tell which physical items you want to render
pov_exporter.AddAll()

 # Tell that you want to render the contacts
##pov_exporter.SetShowContacts(1,
##                            postprocess.ChPovRay.SYMBOL_VECTOR_SCALELENGTH,
##                            0.001,  # scale
##                            0.002,  # width
##                            0.2,    # max size
##                            1,0,0.5 ) # colormap on, blue at 0, red at 0.5

 # 1) Create the two .pov and .ini files for POV-Ray (this must be done
 #    only once at the beginning of the simulation).
pov_exporter.ExportScript()




# If you want to change some settings for the solver, here is the right place
# to do it. For example you might want to use SetIterLCPmaxItersSpeed to set
# the number of iterations per timestep, etc.

#my_system.SetLcpSolverType(chrono.ChSystem.LCP_ITERATIVE_BARZILAIBORWEIN) # precise, more slow
my_system.SetLcpSolverType(chrono.ChSystem.LCP_ITERATIVE_SOR_MULTITHREAD)
my_system.SetIterLCPmaxItersSpeed(70)


# Now perform the simulation by advancing the timestep in a
# loop. For each timestep also write the data for postprocessing
# and write position data for some bricks into recorded vectors that
# will be plotted using the matplotlib tools

result_t   = np.array([])

nstep = 0
max_fall_speed = 0.8

while (my_system.GetChTime() < 15) :

    #limit speed of particles a bit as as in viscous fall in fluid
    for ip in range(0,pebbles.GetNparticles()):
        if (pebbles.GetParticle(ip).GetPos_dt().Length() > max_fall_speed):
            vnspeed = pebbles.GetParticle(ip).GetPos_dt().GetNormalized()
            pebbles.GetParticle(ip).SetPos_dt(vnspeed*max_fall_speed)


    nstep = nstep+1

    if (math.fmod(nstep,6)==0):
        for ix in range(0,n_outlet_x):
            for iz in range(0,n_outlet_z):
                if (created_pebbles >= max_pebbles):
                    break
                offset_particle = chrono.ChVectorD( size_outlet_x * (-0.5+(ix/(n_outlet_x-1))),
                                                    0,
                                                    size_outlet_z * (-0.5+(iz/(n_outlet_z-1))) )
                jitter_particle = chrono.ChVectorD( 0.1*(size_outlet_x/n_outlet_x) * (random.uniform(-1.,1.)),
                                           0.1*diameter_pebble * (random.uniform(-1,1)),
                                           0.1*(size_outlet_z/n_outlet_z) * (random.uniform(-1.,1.)) )
                csys_particle   = chrono.ChCoordsysD( pos_outlet + offset_particle + jitter_particle )

                pebbles.AddParticle(csys_particle)

                # trick: set speed as already falling to avoid overlapping at the top of fountain
                pebbles.GetParticle(pebbles.GetNparticles()-1).SetPos_dt(chrono.ChVectorD(0,-max_fall_speed,0))

                created_pebbles =created_pebbles+1

    my_system.DoStepDynamics(0.005)

    print ('time=', my_system.GetChTime(), "  n particles=", pebbles.GetNparticles())

    # Save data only each n-th step to avoid wasting space on disk
    if (math.fmod(nstep,4)==0):
        pov_exporter.ExportData()
        result_t        = np.append(result_t,   my_system.GetChTime())



