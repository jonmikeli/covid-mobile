#!/bin/bash
#function to get script parameter values
_get_parameter_values ()
{
	echo "===>>>GET PARAMETER VALUES"

	while getopts "s:t:p:l:e:r:f:" option;
	do

		echo ">>>SCRIPT PARAMETERS:$option"
		
		case $option in
			s) subscriptionId=$OPTARG;;
			t) templateFilePath=$OPTARG;;
			p) parametersFilePath=$OPTARG;;
			l) resourceGroupLocation=$OPTARG;;
			e) environment=$OPTARG;;
			r) resourceGroupBaseName=$OPTARG;;
			f) tags+=("$OPTARG");;
		esac
	done
	shift $((OPTIND -1))
	
	if [ -z "$resourceGroupName"]; then
		resourceGroupName="${resourceGroupBaseName}-${environment}"
	fi
	
	if [ -z "$deploymentName"]; then
		deploymentName="${resourceGroupName}-deployment"
	fi

	echo "===>>>END OF GETTING PARAMETER VALUES"

	echo "Subscription id: $subscriptionId"
	echo "Deployment name: $deploymentName"
	echo "Resource group name: $resourceGroupName"
	echo "Template file path: $templateFilePath"
	echo "Parameters file path: $parametersFilePath"
	echo "Resource group location: $resourceGroupLocation"
	echo "Resource group name: $resourceGroupName"
	echo "Solution environment: $environment"
	echo "Tags: ${tags[@]}"
}

#get script parameter values
_get_parameter_values "$@"

#set the default subscription id
az account set --subscription $subscriptionId

#Check for existing RG
az group show --name $resourceGroupName 1> /dev/null

if [ $? != 0 ]; then
	echo "Resource group with name" $resourceGroupName "could not be found. Creating new resource group.."
	set -e
	(
		set -x
		az group create --name $resourceGroupName --location $resourceGroupLocation --subscription $subscriptionId --tags ${tags[@]} environment=$environment 1> /dev/null
	)
	else
	echo "Using existing resource group..."
fi

#Start deployment
echo "Starting deployment..."
set -e
(
	set -x
	az group deployment create \
	--mode Incremental  \
	--name $deploymentName \
	--resource-group $resourceGroupName \
	--template-file $templateFilePath \
	--parameters $parametersFilePath \
	--parameters rgName=$resourceGroupName \
	--parameters location=$resourceGroupLocation \
	--parameters environment=$environment \
	--debug --verbose \
	1> /dev/null
)

if [ $?  == 0 ];
 then
	echo "Template has been successfully deployed"
fi

