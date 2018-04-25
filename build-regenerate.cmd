setlocal
del project.asserts.json /s
set ApplyLockFile=true
set GenerateLockFile=true

call build
call build
