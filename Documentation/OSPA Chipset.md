# OSPA Chipset

## Modules

### SBMM: SPI Bus Master Module

### ULEM: User Logic Execution Module

### TOIM: TCP/IP Operator Interface Module (Ethernet)

### SOIM: Serial Operator Interface Module (RS-232)

### MMIM: Modbus Master Interface Module (RS-485)

### MSIM: Modbus Slave Interface Module (RS-485)

### LIIM: Local I/O Interface Module


## Module Configuration

At minimum, a PLC requires one SBMM and one ULEM.  The board may contain up to 6 additional modules, for a total of 8 modules.  With the exception of the LIIM, a maximum of one of each type of module may be used.  The PLC can have multiple LIIMs.

The maximum number of modules is determined by the number of pins available on the SBMM's microcontroller.  Each chip on the board requires 2 additional pins: one for the *slave select* and one for the *master request*.

* The *slave select* is the standard SPI signal from the master to the slave with which it wants to communicate.  

* The *master request* is a signal from the slave to the master which indicates that the slave would like to communicate with the master.  This signal is held low normally, and pulled high when the slave wants to signal a desire to communicate.  The signal is held high until its slave select  signal is pulled low indicating that the master has initiated SPI communication with the slave, satisfying the slave's request.

