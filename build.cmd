pushd Service2
nuget restore
msbuild /v:m
popd

pushd Service1
nuget restore
msbuild /v:m
popd

pushd CommonCode
nuget restore
msbuild /v:m
popd
