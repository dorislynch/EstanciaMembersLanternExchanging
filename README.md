
# react-native-estancia-members-lantern-exchanging

## Getting started

`$ npm install react-native-estancia-members-lantern-exchanging --save`

### Mostly automatic installation

`$ react-native link react-native-estancia-members-lantern-exchanging`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-estancia-members-lantern-exchanging` and add `RNEstanciaMembersLanternExchanging.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNEstanciaMembersLanternExchanging.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNEstanciaMembersLanternExchangingPackage;` to the imports at the top of the file
  - Add `new RNEstanciaMembersLanternExchangingPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-estancia-members-lantern-exchanging'
  	project(':react-native-estancia-members-lantern-exchanging').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-estancia-members-lantern-exchanging/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-estancia-members-lantern-exchanging')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNEstanciaMembersLanternExchanging.sln` in `node_modules/react-native-estancia-members-lantern-exchanging/windows/RNEstanciaMembersLanternExchanging.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Estancia.Members.Lantern.Exchanging.RNEstanciaMembersLanternExchanging;` to the usings at the top of the file
  - Add `new RNEstanciaMembersLanternExchangingPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNEstanciaMembersLanternExchanging from 'react-native-estancia-members-lantern-exchanging';

// TODO: What to do with the module?
RNEstanciaMembersLanternExchanging;
```
  