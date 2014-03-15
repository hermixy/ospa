all:
	@echo Available commands:
	@echo make windows
	@echo make linux
	@echo make clean
	@echo make run

windows:
	make -f Makefile.windows

linux:
	make -f Makefile.linux

clean:
	rm -f bin/* obj/*

run:
	./bin/ospasoft 2> /dev/null &
