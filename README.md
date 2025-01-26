### GGJ_2025_BubbleSort_XR
# Bubble Game 🎈 (Global Game Jam 🎮) 
Videojuego en realidad mixta para el aprendizaje lúdico del algoritmo Bubble Sort.

## Demo
![image](https://github.com/user-attachments/assets/7591d6db-8f21-4293-8f5d-4a57221e0ab2)

## Instrucciones para compilar y ejecutar
Este documento explica cómo compilar el proyecto de Unity y cargar el archivo APK en tu dispositivo Meta Quest utilizando **SideQuest**. Sigue estos pasos para ejecutar el juego en tu dispositivo.

---

## Requisitos Previos

1. **Unity Hub y Unity 2022.3 o superior**: Asegúrate de tener instalada una versión compatible de Unity.
2. **Android Build Support**: Dentro de Unity Hub, instala el módulo de soporte para Android.
3. **Meta Quest Device**: Un dispositivo Meta Quest (Quest 1, Quest 2, Quest 3 o Quest Pro).
4. **SideQuest**: Instala SideQuest en tu computadora ([descargar SideQuest](https://sidequestvr.com/)).
5. **Cable USB**: Un cable USB-C para conectar tu dispositivo Meta Quest a la computadora.

---

## Pasos para Compilar el Proyecto en Unity

1. **Abre el Proyecto en Unity**:
    - Abre Unity Hub y carga el proyecto del juego desde la carpeta donde se encuentra el código fuente.
2. **Configura las Opciones de Build**:
    - Ve a `File > Build Settings`.
    - Selecciona la plataforma **Android** y haz clic en `Switch Platform`.
    - Asegúrate de que el `Texture Compression` esté configurado en **ASTC**.
3. **Configura el Player Settings**:
    - Haz clic en `Player Settings` en la ventana de Build Settings.
    - En `Other Settings`, asegúrate de que:
        - **Minimum API Level**: Android 7.0 'Nougat' (API Level 24) o superior.
        - **Target API Level**: Android 12 (API Level 31) o superior.
        - **Install Location**: Automatic.
        - **Write Permission**: External (SDCard).
    - En `XR Plug-in Management`, habilita **Oculus** como proveedor de XR.
4. **Genera el APK**:
    - En la ventana de Build Settings, haz clic en `Build`.
    - Selecciona una carpeta de destino para guardar el archivo APK.
    - Unity generará el archivo APK en la ubicación especificada.

---

## Cargar el APK en tu Dispositivo Meta Quest con SideQuest

1. **Prepara tu Dispositivo Meta Quest**:
    - Conecta tu dispositivo Meta Quest a la computadora usando un cable USB-C.
    - Asegúrate de que el dispositivo esté encendido y que hayas habilitado el modo desarrollador:
        - Ve a la app de Oculus en tu teléfono.
        - Selecciona tu dispositivo y habilita `Developer Mode`.
        - Reinicia el dispositivo si es necesario.
2. **Abre SideQuest**:
    - Inicia SideQuest en tu computadora.
    - Conecta tu dispositivo Meta Quest a SideQuest. Deberías ver un mensaje de conexión exitosa en la parte superior de la ventana.
3. **Carga el APK**:
    - En SideQuest, haz clic en el botón `Install APK from Folder` (el ícono de carpeta con una flecha hacia arriba).
    - Selecciona el archivo APK generado por Unity.
    - SideQuest instalará el APK en tu dispositivo Meta Quest.
4. **Ejecuta el Juego**:
    - Desconecta tu dispositivo de la computadora.
    - En tu Meta Quest, ve a la sección `Apps > Unknown Sources`.
    - Busca el nombre del juego y selecciónalo para iniciarlo.

---

¡Listo! Ahora deberías poder disfrutar del juego en tu dispositivo Meta Quest. Si encuentras algún problema, revisa la configuración de Unity o consulta la documentación de SideQuest para más detalles. 🚀

## Compatibilidad del Juego - Global Game Jam 2025
Nuestro juego fue desarrollado originalmente para **Meta Quest 3S**, pero se ha optimizado para ser compatible con los siguientes dispositivos de la familia Meta Quest:

- **Meta Quest 3** (Plataforma principal de desarrollo)
- **Meta Quest 2**
- **Meta Quest Pro**

**Nota**: Aunque el juego es compatible con todos los dispositivos mencionados, el rendimiento y la calidad visual pueden variar según las capacidades de hardware de cada dispositivo. 

¡Disfruta de la experiencia en tu dispositivo Meta Quest! 🎮

##📬 Información de Contacto del Equipo
**¡Conéctate con el equipo de desarrollo!**

Agradecemos comentarios, colaboraciones y preguntas sobre el proyecto. Formas de contactarnos:

### **Equipo Principal**

| Nombre | Rol | Correo Electrónico |
| --- | --- | --- |
| Daryl Butrón | Desarrollador XR | `daryl.butron@ucsp.edu.pe` |
| Alejandro Delgado | Artista 3D/Animadora | `alejandro.delgado@ucsp.edu.pe` |
| Jean Paul Ari | Diseño de Sonido y Emotes | `jean.ari@ucsp.edu.pe` |
| Jessica Hancco | Maquetación y Documentación | `jhanccove@unsa.edu.pe` |
| Pstrick Ramírez | Diseño gráfico y Documentación | `pramirezs@ulasalle.edu.pe` |


### 📍 **Métodos de Contacto Preferidos**

1. **Reporte de Errores**:
    
    Abre un informe en nuestro [repositorio de GitHub](https://github.com/dabc312GitHub/GGJ_2025_BubbleSort_XR.git).
    
2. **Prensa/Patrocinadores**:
    
    Usa el asunto **"Colaboración XR GGJ2025"** al escribir a `daryl.butron@ucsp.edu.pe`.
    
---

### 🕒 **Tiempos de Respuesta**

Nuestro objetivo es responder en **3-5 días hábiles**, pero ten en cuenta posibles demoras durante periodos ocupados tras la game jam.

---

*Para asuntos urgentes relacionados con licencias de código abierto, contacta directamente al desarrollador principal.*
