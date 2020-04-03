#!/bin/bash
./0-AzFullDeployment-NotNested.sh \
-s "2cd935d8-485e-40f2-9ef7-d3ae932e4508" \
-r "SIT-IA-POC-IMS-F1" \
-t "../AzureFullDeployNotNested.json" \
-p "@../AzureFullDeploy.TOTAL-IMS-F1.parameters-int.json" \
-l "westeurope" \
-e "int" \
-f "applicationName=IMS-pov1 applicationType=AI-PoC createdBy=srousseau friendlyName='Proof_of_Value_AI-U1' owner=HLD usage=dev project='Total-IMS' feature=F1 version=v0.1"

