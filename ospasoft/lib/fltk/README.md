FLTK
----

The FLTK 1.3.2 source code does not compile under MinGW and Mac without modifications.  The modified source and prebuilt libraries are provided in this directory.  For MinGW and Mac, the platform Makefile references these prebuilt libraries directly, so no system install is required.  For Linux, the command "sudo apt-get install libfltk1.3-dev" installs the FLTK library without needing any modifications.  The Linux Makefile uses the system's FLTK installation, so no prebuilt Linux libraries are provided here.
