# OSPA Chipset

## Modules

### SBMM - SPI Bus Master Module

### ULEM - User Logic Execution Module

### TOIM - TCP/IP Operator Interface Module (Ethernet)

### SOIM - Serial Operator Interface Module (RS-232)

### SIIM - Serial I/O Interface Module (RS-485)

## Configuration

Every PLC requires one SBMM to facilitate communication between other modules on the board, and one ULEM to execute the user program.  The board may contain up to 6 additional chips, for a total of 8 chips.  

This maximum is limited by the number of pins available on the SBMM's microcontroller.  Each chip on the board requires 2 additional pins on the SBMM's microcontroller: one for the *slave select* and one for the *master request*.  

* The *slave select* is the standard SPI signal from the master to the slave with which it wants to communicate.  
* The *master request* is a signal from the slave to the master which indicates that the slave would like to communicate with the master.  This signal is held high normally, and pulled low when the slave wants to signal a desire to communicate.  The signal is held low until its slave select signal is pulled low indicating that the master has initiated SPI communication with the slave, satisfying the slave's request.
