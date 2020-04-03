#!/bin/bash
resourceGroupName="IoTCovid"
resourceGroupLocation="eastus"
sku=S1
iotCentralName="iotcovid"
iotCentralDisplayName="IoT Covid Hub"
iotCentralApplicationName="iotcovidhub"

echo "Creating the application..."
az group create --name $resourceGroupName --location $resourceGroupLocation 1> /dev/null
az iotcentral app create --resource-group $resourceGroupName --name $iotCentralName --sku $sku --location $resourceGroupLocation --subdomain $iotCentralApplicationName --template iotc-pnp-preview --display-name $iotCentralDisplayName
echo "Application created"