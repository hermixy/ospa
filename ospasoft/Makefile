CC=g++
CFLAGS=-std=c++0x -Wall -Wunused -Wno-format-y2k -fno-exceptions -fno-strict-aliasing -I./include -I./lib/fltk/include -mwindows -DWIN32 -DUSE_OPENGL32  -D_LARGEFILE_SOURCE -D_LARGEFILE64_SOURCE
LDFLAGS=-L./lib/fltk/lib -lfltk -lole32 -luuid -lcomctl32 -mwindows -static-libgcc -static-libstdc++
SOURCES=\
	src/main.cpp \
	src/NewTaskWindowDriver.cpp \
	src/ProgramWindowDriver.cpp \
	src/UserInterface.cpp
OBJECTS=$(SOURCES:.cpp=.o)
EXECUTABLE=bin/ospasoft.exe

all: obj bin $(SOURCES) $(EXECUTABLE)

clean:
	rm -f bin/* obj/*

run:
	./$(EXECUTABLE) &

obj:
	mkdir obj/

bin:
	mkdir bin/

$(EXECUTABLE): $(OBJECTS) 
	@echo $(CC) -o $@
	@$(CC) $(CFLAGS) $(subst src/,obj/,$(OBJECTS)) $(LDFLAGS) -o $@ 

.cpp.o:
	@echo $(CC) $(subst .o,.cpp,$@)
	@$(CC) $(CFLAGS) -c $< -o $(subst src/,obj/,$@)
