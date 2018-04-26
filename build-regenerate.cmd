setlocal
del project.assets.json /s
set ApplyLockFile=true
set VerifyLockFile=false
set GenerateLockFile=true
call build

