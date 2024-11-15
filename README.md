# FFMPEG-QTTabBar-Tools

*This repo is for personal use only & very WIP*

### Usage:

1. Build in Release | Any CPU

2. Move to appropriate path like "C:\Program Files\QTTabBar Plugins"

3. Drag .exe into QTTabBar Command Bar

4. Right click on newly appeared icon

5. Edit...

6. Arguments - add %f% - for currently selected file(s).

***

### `QTTB-Trimmer`

`ffmpeg -copyts -ss [start] -i in.mp4 -to [end] -map 0 -c copy out.mp4` from https://superuser.com/a/377407 (no re-encode)

Some videos can break in telegram with this method. In those cases, use duration version instead.

![SCREENSHOT](https://raw.githubusercontent.com/sjain882/FFMPEG-QTTabBar-Tools/refs/heads/main/Previews/QTTB-Trimmer.png?raw=true)
***

### `QTTB-Trimmer-Duration`

`ffmpeg -ss [start] -i in.mp4 -t [duration] -map 0 -c copy out.mp4` from https://superuser.com/a/377407 (no re-encode)

Works fine with telegram.

![SCREENSHOT](https://raw.githubusercontent.com/sjain882/FFMPEG-QTTabBar-Tools/refs/heads/main/Previews/QTTB-Trimmer-Duration.png?raw=true)
