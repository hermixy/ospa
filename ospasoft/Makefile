all:
	@echo Available commands:
	@echo 	make windows
	@echo 	make linux
	@echo 	make mac
	@echo 	make clean
	@echo 	make run

windows:
	make -f Makefile.windows

linux:
	make -f Makefile.linux

mac:
	make -f Makefile.mac

clean:
	rm -rf ./bin/OSPASOFT.app
	rm -f ./bin/*
	rm -f ./obj/*

run:
	./bin/ospasoft 2> /dev/null &
