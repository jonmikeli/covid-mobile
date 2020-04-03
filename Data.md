# Covid data gatherer - DATA
 
The purpose of the application is merely to collect useful data for scientists, coming from patients directly.
It seems that not all the patients are registered in hospitals and we are maybe losing precious information for doctors.

## Data

Functional description:
 - Device ID (technical, could be the IMEI) (string)*
 - Date of record creation (date)*
 - Date of record transmission (date)*
 - Age (integer)*
 - Gender (string, enumeration ideally)*
 - Symptoms:
     - Temperature (boolean)*
     - Temperature value (decimal)
     - Temperature description (string)
     - Muscular pain (boolean)*
     - Muscular pain level (from 1-light to 5-strong)
     - Muscular pain description (string)
     - Cough (boolean)*
     - Cough level (from 1-light to 5-strong)
     - Cough description (sring)
     - Smell (boolean)*
     - Smell description (sring)
     - Taste (boolean)*
     - Taste description (sring)
     - Headaches (boolean)*
     - Headaches description (sring)
     - Improving (boolean)     
     - Other (sring)
 - Environment:
     - housing (string, enumeration ideally)
     - transportation (string, enumeration ideally)
     - location (string)
     - social distance (enumeration, metric to define)
 - Precautions:
     - Mask
     - Gloves
     - Cleaning frecuency


## Format

JSON
{
    "deviceId":"",
    "recordDate":"20200403T22:10:05",
    "transmissionDate":"20200403T22:10:05",
    "age":35,
    "gender":"male",
    "temperature":true,
    "temperatureValue":10.2,
    "temperatureDescription":"only the morning",
    "muscularPain":false,
    
}
