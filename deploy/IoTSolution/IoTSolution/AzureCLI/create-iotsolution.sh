#!/bin/bash
./0-AzFullDeployment-NotNested.sh \
-s "[to be replaced]" \
-r "IOT-COVID" \
-t "../AzureFullDeployNotNestedARM.json" \
-p "@../AzureFullDeploy.parameters-dev.json" \
-l "westeurope" \
-e "dev" \
-f "project='IoT-COVID' module='IoTSolution' version=v0.1"

