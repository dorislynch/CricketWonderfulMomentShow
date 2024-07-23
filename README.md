
# react-native-cricket-wonderful-moment-show

## Getting started

`$ npm install react-native-cricket-wonderful-moment-show --save`

### Mostly automatic installation

`$ react-native link react-native-cricket-wonderful-moment-show`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-cricket-wonderful-moment-show` and add `RNCricketWonderfulMomentShow.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNCricketWonderfulMomentShow.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNCricketWonderfulMomentShowPackage;` to the imports at the top of the file
  - Add `new RNCricketWonderfulMomentShowPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-cricket-wonderful-moment-show'
  	project(':react-native-cricket-wonderful-moment-show').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-cricket-wonderful-moment-show/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-cricket-wonderful-moment-show')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNCricketWonderfulMomentShow.sln` in `node_modules/react-native-cricket-wonderful-moment-show/windows/RNCricketWonderfulMomentShow.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Cricket.Wonderful.Moment.Show.RNCricketWonderfulMomentShow;` to the usings at the top of the file
  - Add `new RNCricketWonderfulMomentShowPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNCricketWonderfulMomentShow from 'react-native-cricket-wonderful-moment-show';

// TODO: What to do with the module?
RNCricketWonderfulMomentShow;
```
  