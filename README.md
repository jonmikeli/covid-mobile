# Covid data gatherer

## Purpose
The purpose of the project is to build a simple solution allowing to colect and gather data related to covid-19 from all around the world.

Data will be related to symptoms and how people live the disease.

The only target of all this is to provide to the scientific community as much data as possible about what people has been experiencing.

> IMPORTANT
> No personal data will be required and all the data will be anonymized.
> There is no interest on tracking an individual person nor having that possibility at any given time. Privacy above all.

## Type of collected data
The type of data will be determined with doctors and/or scientists.
At first sight, we could imagine data like:
 - symptoms
 - phases
 - dates

As mentioned earlier, data will be anonymized to preserve privacy.
This needs to be underlined as many times as required and all the developments have to take care of this.

## Format and structure of data
The format of data will be JSON.

Regarding its structure, ideally, a standard data schema would be nice (ex: FHIR related flows?).
That said, not sure there is one for this kind of purposes. Also, we need to be very fast in all this implementation to gather pertinent data.

So, let's define our schema, trying to gather the required data.

Once stored, other processes can take in charge mapping or format changing tasks.

## Solution
The approach in mind is to use the very extense market of cell phones all around the world. They could behave as IoT devices through a mobile application.
That application, in turn, will host IoT features and behave as an IoT device.


### Why not to use a conventional solution?
A more "classic" solution would be to develop a mobile application and make it push the data through APIs, queues or message brokers (for instance, Azure Event Hub or Kafka). This would work properly as for as concerned the purpose of gathering data.

However, the solution will miss many interesting and useful IoT features. It would be unfortunate to get rid of all that having the possibility to use them.

TODO: diagram

### Smart IoT
The creative aspect of the proposed solution resides on the fact that there is no IoT device. This role will be played by an application hosted in a mobile application (phone application).

### Flows
#### D2C
Data from the application to a given IoT Hub.
Once data in the IoT solution, it can follow different routes depending on the requirements we agree upon.

#### C2D
The type of communication between the cloud solution and the IoT client application will be:
 - Twins (Desired, Reported Properties and Tags)
 - Messages
 - Commands

This may allow to implemente use cases like:
 - configuration changes
 - request data
 - request application reinitializations
 - IoT device application updates (not mobile application updates)

### Storage
Data will be stored as raw data in cold storages.
The used storages could feed other data lakes, analytics or any other flow meant to process and extract value.

## Global architecture
The architecture of the solution would be a an IoT-oriented architecture.
TODO Diagram

# Implementation



# Conditions

## Conditions of data use