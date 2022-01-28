# Json for Unity

This provides Json converter for Unity.
By default, it uses `UnityEngine.JsonUtility`.
But it prioritize using such modules first: `Newtonsoft.Json`.

- Features

	```bash
	- Json serialize (convert C# object to json-string).
	- Json deserialize (convert json-string to C# object).
	```

- Dependencies

	```bash
	# [Option]
	Newtonsoft.Json

	# Tool.Compet.Core
	https://github.com/darkcompet/csharp-unity-core
	```


## How to install

- Just include it into project by add as git-submodule.
	
	```bash
	# Tool.Compet.Core
	git submodule add https://github.com/darkcompet/csharp-unity-core.git
	```
