setlocal
del project.assets.json /s
set ApplyLockFile=true
set GenerateLockFile=true

call build
