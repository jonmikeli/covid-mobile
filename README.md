# Covid data gatherer

## Purpose
The purpose of the project is to build a simple solution allowing to gather data related to covid-19 from all around the world.

Data will be related to symptoms and how people live the disease.
what is targetted behind is to provide to the community as much data as possible about what people has been experiencing.

## Type of data
The type of data will be determined with doctors and/or scientists.
At first glance we could imagine data like:
 - symptoms
 - phases
 - dates

Data will be anonymized to preserve intimacy.
The idea behind is to build valuable data repositories to allow scientists in their researchs.


## Solution
The approach in mind is to use the already very extense market of cell phones all around the world.
However, instead of using a regular data flow approach through APIs, queues or message brokers (for instance, Event Hub, Kafka), using IoT oriented services could beneficial and profitable for many use cases.

The creative aspect of the proposed solution resides on the fact that there is no IoT device. That role will be played by an application embedded in a mobile application (phone application).


## Global architecture
TODO Diagram

## Flows
### D2C
Data from the application to a given IoT Hub.

### C2D
The type of communication between the cloud solution and the IoT client application will be:
 - Twins (Desired, Reported Properties and Tags)
 - Messages
 - Commands

Examples:
TODO

## Storage
Data will be stored as raw data in cold storages.
The used storages could feed other data lakes, analytics or any other flow meant to process and extract value.

# Conditions

## Condtions of data use