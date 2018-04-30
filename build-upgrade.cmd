setlocal
del project.assets.json /s
del nuget.lock.props /s
set ApplyLockFile=true
set VerifyLockFile=false
set GenerateLockFile=true

call build
