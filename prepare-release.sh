#!/bin/bash

set -e

if [ -z "$1" ]
then
  echo "Please specify the API you're releasing, e.g. Google.Cloud.Storage.V1"
  exit 1
fi

# Make sure we have all the tags locally.
git fetch --tags -f -q upstream master

echo "Building $1"
./build.sh $1 --notests
echo ""

echo "Updating release notes at:"
echo "apis/$1/docs/history.md"
dotnet run -p tools/Google.Cloud.Tools.UpdateReleaseNotes -- $1
echo ""

echo "Checking version compatibility"
dotnet run -p tools/Google.Cloud.Tools.CheckVersionCompatibility -- $1
