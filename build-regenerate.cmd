setlocal
del project.assets.json /s
set ApplyLockFile=true
set FlattenLockFile=false
set GenerateLockFile=true
call build

set FlattenLockFile=true
call build
call build
