#!/bin/bash
./ParameterTests.sh \
-s "ec91c862-9472-4bb7-9c61-64727c764b8b" \
-r "SIT-IA-POC-IMS-F1" \
-t "../AzureFullDeployNotNested.json" \
-p "@../AzureFullDeploy.TOTAL-IMS-F1.parameters-dev-tests.json" \
-l "westeurope" \
-e "dev" \
-o "IMS" \
-v "v0.1" \
-f "applicationName=IMS-pov1 applicationType=AI-PoC createdBy=srousseau friendlyName='Proof of Value AI-U1' owner=HLD usage=dev project='Total-IMS' feature=F1 environment=dev version=v0.1"
