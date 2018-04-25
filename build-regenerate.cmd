setlocal
del project.asserts.json /s
set ApplyLockFile=true
set FlattenLockFile=false
set GenerateLockFile=true
call build

set FlattenLockFile=true
call build
call build
