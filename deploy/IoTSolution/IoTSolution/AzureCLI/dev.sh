#!/bin/bash
./0-AzFullDeployment-NotNested.sh \
-s "ec91c862-9472-4bb7-9c61-64727c764b8b" \
-r "IOT-COVID" \
-t "../AzureFullDeployNotNestedARM.json" \
-p "@../AzureFullDeploy.parameters-dev.json" \
-l "westeurope" \
-e "dev" \
-f "project='IoT-COVID' module='IoTSolution' version=v0.1"

