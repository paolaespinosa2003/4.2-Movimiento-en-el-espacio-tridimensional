
# Proyecto Unity 3D - Helix-like Template (Entrega Actividad 4.2)

Este repositorio contiene un proyecto Unity **lista para abrir** que implementa:
- Movimiento en el espacio 3D (avance automático y control lateral).
- Sistema de Score visible en pantalla y HighScore persistente (PlayerPrefs).
- Curva de dificultad progresiva que aumenta la velocidad con el tiempo/score.
- Estructura ordenada para subir a GitHub: Assets, ProjectSettings, Packages.

**Versión de Unity sugerida**: 2022.3.x LTS (se incluyó ProjectVersion.txt con 2022.3.0f1).

## Cómo usar
1. Descarga y extrae el ZIP.
2. Abre Unity Hub -> Open -> selecciona la carpeta del proyecto.
3. Abre la escena `Assets/Scenes/MainScene.unity`.
4. Ejecuta (Play).

## Contenido principal
- Assets/Scenes/MainScene.unity  -> Escena principal con Camera, Player, Canvas.
- Assets/Scripts/PlayerMovement.cs -> Movimiento y colisiones.
- Assets/Scripts/ScoreManager.cs -> Control de score y HighScore (PlayerPrefs).
- Assets/Scripts/DifficultyManager.cs -> Aumenta dificultad con el tiempo.
- Assets/Scripts/CameraFollow.cs -> Cámara que sigue en X,Z y mantiene Z fijo.
- Assets/Scripts/UIManager.cs -> Actualiza texto del UI.

## Nota
Al abrir por primera vez, Unity generará algunos archivos automáticos (Library, etc.).
Si quieres que incluya más assets, prefabs o una versión exportada para Android, dímelo.
