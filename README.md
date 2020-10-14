# processing_of_thermograms

The project was devoted to the analysis of thermograms. Its main function is to aid in the analysis of thermographic images, but it also works for ordinary images. The layout of the user panel looks like this:

![](fotos/main_layout.PNG)

The purpose of the filters is to detect potential defects in the area shown in the photos. This is to help eliminate potential material leakage defects. Composite materials were used for the tests, which are used, for example, in aviation in the construction of aircraft. The application was designed to check which filters help to find potential defects of materials.
The available filters are:
-median filter
-gauss filter
-stretch histogram
-palette in various colors
-discrete transform Fourier
-first and second derivatives
-edge detection

Example palette of colors:

-cold colors

![](fotos/blue.PNG)

-warm colors

![](fotos/orange_color.PNG)

ROI- Region of Interest in image:

![](fotos/ROI.png)

Median filter 7x7:

![](fotos/median7x7.png)

Gauss filter:

![](fotos/gauss.png)

Image histogram:

![](fotos/histogram.PNG)

Stretch histogram in image:

![](fotos/stretch_histogram.png)

Image contrast:

![](fotos/image_contrast.PNG)

Edge detection(first on the left is X detection, second Y and last is X and Y):

![](fotos/edge_detection.png)

Derivatives(left is original,second used first derivatives and last used second derivatives):

![](fotos/derivatives.png)

Discrete Transform Fouriere(amplitude in the middle and phase on right):

![](fotos/dft.png)
