# Investigación

Paquete para hacer VR
https://developers.google.com/vr/develop/unity/get-started-android

Tuto con paquete anterior
https://www.youtube.com/watch?v=KZ90tgWvNuE

Importar SVG, al final no se utilizó
https://stackoverflow.com/questions/52562020/how-to-import-svg-to-unity-2018-2

Exportar FBX, tampoco se utilizó
https://docs.unity3d.com/es/530/Manual/HOWTO-exportFBX.html

Versión de Unity 2019.3
Se debe poder cambiar a otra versión 2019.X

Primerso se usó formato SVG para las imágenes de reactivos, pero tenían errores en los colores de relleno.
Se va a utilizar mejor PNG

Ejemplos que pueden ayudar
https://aframe.io

Modificar los XRsettings dentro del código no parece buena opción
https://docs.unity3d.com/ScriptReference/XR.XRSettings.html
https://forum.unity.com/threads/disable-stereo-rendering-with-cardboard-and-gear-sdk.497214/
https://forum.unity.com/threads/vr-cardboard-ui-screen-space-overlay-canvas-with-new-native-carboard-vr-sdk-in-unity-5-6-0.466677/
https://forum.unity.com/threads/vr-mode-with-mono-camera.479031/



Quickstart for Google VR SDK for Unity with Android

Cardboard: Android 4.4 'KitKat' (API level 19) or higher

Unity recomended version LTS 2018.4 or newer (se usará 2019.3)

Instalar Android Build Support

Descargar "GoogleVRForUnity_*.unitypackage"
Usaremos "GoogleVRForUnity_1.200.1.unitypackage" (GVR SDK for Unity v1.200.1 (2019-07-17))

1. Crear nuevo proyecto 3D
2. Assets > Import Package > Custom Package
3. Selecionar unitypackage descargado, clic Import
4. File > Build Settings
5. Seleccionar Android, clic Switch Platform
6. En Player Settings > XR Settings poner
    VR Supported - Enabled
	VR SDKs - Cardboard
7. En Player Settings > Other Settings
    Min API level - 4.4 'KitKat'
8 Opcional en Player Settings > Package Name
    Nombre de la aplicación
9. Abrir demo en Google VR > Demos > Scenes > HeloVR
10. Presiona Play, gira con Alt+mouse, inclina vista con Ctrl+mouse, clic en cualquier lugar de la pantalla

Revisar estado de Android: Edit > preferences > External Tools
Cambiar color al presionar botón Play: Edit > preferences > Colors

Assets necesarios (prefabs)
- GvrEventSystem
- GvrEditorEmulator
- GvrControllerMain
- Game Object > 3D Object
- Materiales: Create > New material, arrastrar a objeto
- Para mover la cámara, objeto player Create Empty, Main Camera como hijo
- CubeRoom
- GvrReticlePointer como hijo de Main Camera, rev tag "Main Camera"
- GvrPointerPhysicsRaycaster ??
- En 3D Object, Add Component > Event Trigger >Add New ... > PointerEnter, arrastrar objeto que interactua
- Save Scene

Se generan muchos warnings usando el mínimo de objetos. La escena HelloVR no genera los warnings, ¿qué objetos faltan?

## Texture swap
Buscar: "Unity texture swap"  

Hacer un public array y arrastrar las texturas  
https://www.youtube.com/watch?v=aLOru6QQShM  

https://forum.unity.com/threads/swapping-texture-via-script.3124/  
https://docs.unity3d.com/ScriptReference/AssetDatabase.FindAssets.html  
https://forum.unity.com/threads/load-png-into-sprite-then-draw-sprite-onto-screen.433489/  

Cargar desde Resources  
https://stackoverflow.com/questions/41775635/how-to-change-the-sprite-of-a-ui-image-element-at-runtime-to-one-in-my-assets-fo  

https://answers.unity.com/questions/1417421/how-to-load-all-my-sprites-in-my-folder-and-put-th.html  
Se usará el método de public array.  

## Problema al asignar sprite, faltaba using...UI
Asignar sprite a objetos UI  
https://answers.unity.com/questions/1013679/trying-to-change-source-image-of-ui-image-via-scri.html  

## Crear UI
UI system VR  
https://www.youtube.com/watch?v=__iTtJHZg6k  
Hacer un menú (con objetos UI)  
https://www.youtube.com/watch?v=zc8ac_qUXQY  

## Enviar correo electrónico  
Se usa una cuenta de gmail, que tiene activado el uso de apps no seguras    
https://unity3dtuts.com/how-to-send-email-from-unity3d/  
https://answers.unity.com/questions/433283/how-to-send-email-with-c.html

## Puntero con barra de carga circular  
Sin gaze pointer  
http://gyanendushekhar.com/2017/03/28/radial-circular-progress-bar-unity3d/  
Personalizar gaze pointer  
https://answers.unity.com/questions/1081180/customise-the-gazepointer-of-google-cardboard-unit.html  

## Teclados VR
Como tambor, no sirve para Cardboard  
https://github.com/campfireunion/VRKeys  

Buen teclado, no logramos activar el clic con fijar la mirada  
http://talesfromtherift.com/vr-canvas-keyboard/

Teclado a $20 (dólares?)  
https://assetstore.unity.com/packages/tools/input-management/keyboard-vr-83143  

## Teclado nativo android  
Mobile Keyboard
https://docs.unity3d.com/Manual/MobileKeyboard.html  

Propiedad text de touch kb  
https://docs.unity3d.com/ScriptReference/TouchScreenKeyboard-text.html  

Abrir touch kb con script  
https://docs.unity3d.com/ScriptReference/TouchScreenKeyboard.Open.html  

## Simular clic o toque en pantalla o click gaze, No se ha logrado
https://answers.unity.com/questions/820599/simulate-button-presses-through-code-unity-46-gui.html  
https://gamedev.stackexchange.com/questions/163317/trigger-the-buttons-onclick-after-checking-that-the-cursor-has-been-on-it-for-s  
https://stackoverflow.com/questions/59529205/is-there-a-gaze-only-as-opposed-to-click-button-input-mode-in-unity3d-google-v  
https://forum.unity.com/threads/timed-gaze-input-selection-trigger-for-cardboard.373706/  

## Variables globales  
Static class, método utilizado  
https://forum.unity.com/threads/c-global-variables-available-to-all-scenes.544901/  

Otro poco de info  
https://answers.unity.com/questions/924355/how-do-you-make-a-global-variable-global-in-unity.html  

Singleton?  
http://wiki.unity3d.com/index.php/Singleton?_ga=2.254770632.1939526605.1599763368-1000086856.1594949073  

## Puede servir
Controlar GameObjects con Components  
https://docs.unity3d.com/Manual/ControllingGameObjectsComponents.html  



Editar componente de objeto hijo  
https://docs.unity3d.com/ScriptReference/Component.GetComponentInChildren.html  

Parece intro al sdk  
https://medium.com/@jhlink/5-storytellers-dilemma-cardboard-interactions-e73a9bd0e3f6  
https://www.sitepoint.com/what-in-the-world-is-a-reticle-cardboard-unity-sdk/  
