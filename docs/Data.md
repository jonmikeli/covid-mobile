# Covid data gatherer - DATA
 
The purpose of the application is merely to collect useful data for scientists, coming from patients directly.
It seems that not all the patients are registered in hospitals and we are maybe losing precious information for doctors.

## Data

Functional description:
 - Device ID (technical, could be the IMEI) (string)
 - Date of record creation (date)
 - Date of record transmission (date)
 - Age (integer)
 - Gender (string, enumeration ideally)
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
     - Smell loss (boolean)
     - Smell loss description (sring)
     - Taste loss (boolean)
     - Taste loss description (sring)
     - Headaches (boolean)
     - Headaches description (sring)
     - Improving (boolean)     
     - Other (sring)
 - Environment:
     - housing (string, enumeration ideally)
     - transportation (string, enumeration ideally)
     - city (string)
     - country (string)
     - social distance (enumeration, metric to define)


## JSON Schema

A [JSON schema](../schemas/dataSchema.json) describes all this with formalism and additional information:
 - formats
 - allowed values
 - required fields

## JSON data example

[This](../json/data.json) is a sample of data in [JSON](../json/data.json).


