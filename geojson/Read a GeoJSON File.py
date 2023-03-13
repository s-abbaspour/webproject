# -*- coding: utf-8 -*-
"""
Created on Thu Mar  9 21:12:38 2023

@author: Saeideh
"""

#==============================================
# Read a GeoJSON File into GeoPandas DataFrame
#The cities of East Azarbaijan province
#==============================================
#1/usr/bin/env python
#-*-coding:utf-8-*-
import geopandas as gpd
import matplotlib.pyplot as plt

geofile=gpd.read_file('geojsonfile.json')

#================================================
#export
#================================================
geofile.plot(edgecolor='yellow',facecolor='green')
plt.show()
print(geofile)
