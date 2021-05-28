@echo off
set /p ModuleName="Enter Module Name: "

git submodule add https://github.com/BionicApe/%ModuleName Plugins/%ModuleName
git submodule update --init --recursive
git commit -m 'Added new Plugin %ModuleName'