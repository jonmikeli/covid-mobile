#!/bin/bash
#function to get script parameter values
_get_parameter_values ()
{
	echo "===>>>GET PARAMETER VALUES"

	while getopts "s:t:p:l:e:r:o:v:f:" option;
	do				
		case $option in
			s) subscriptionId=$OPTARG;;
			t) templateFilePath=$OPTARG;;
			p) parametersFilePath=$OPTARG;;
			l) resourceGroupLocation=$OPTARG;;
			e) environment=$OPTARG;;
			r) resourceGroupBaseName=$OPTARG;;
			o) projectName=$OPTARG;;
			v) version=$OPTARG;;
			f) featureCode+=("$OPTARG");;
		esac
	done
	shift $((OPTIND -1))
				
	echo "The first value of the array is: $featureCode"
	echo "The whole list of values is: ${featureCode[@]}"
}

#get script parameter values
_get_parameter_values "$@"

if [ $?  == 0 ];
 then
	echo "Template has been successfully deployed"
fi

