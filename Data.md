# Covid data gatherer - DATA
 
The purpose of the application is merely to collect useful data for scientists, coming from patients directly.
It seems that not all the patients are registered in hospitals and we are maybe losing precious information for doctors.

## Data

Functional description:
 - Phone IMEI (technical) (string)
 - Date of record creation (date)
 - Date of record transmission (date)
 - Age (integer)
 - Symptoms:
     - Temperature (boolean)
     - Temperature value (decimal)
     - Temperature description (string)
     - Muscular pain (boolean)
     - Muscular pain level (from 1-light to 5-strong)
     - Muscular pain description (string)
     - Cough (boolean)
     - Cough level (from 1-light to 5-strong)
     - Cough description (sring)
     - Smell (boolean)
     - Smell description (sring)
     - Taste (boolean)
     - Taste description (sring)
     - Headaches (boolean)
     - Headaches description (sring)
     - Other (sring)


## Format

JSON
{
    "imei":"",
    "temperature":true,
    "temperatureValue":10.2,
    "temperatureDescription":"only the morning"
}
