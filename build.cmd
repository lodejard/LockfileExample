pushd Service2
nuget restore
msbuild
popd

pushd Service1
nuget restore
msbuild
popd

pushd CommonCode
nuget restore
msbuild
popd

