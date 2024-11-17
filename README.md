# FFMPEG-QTTabBar-Tools

*No support provided*

### Usage:

1. Build in Release | Any CPU (Visual Studio 2019)

2. Move to appropriate path like "C:\Program Files\QTTabBar Plugins"

3. Drag .exe into QTTabBar Command Bar

4. Right click on newly appeared icon

5. Edit...

6. Arguments - add %f% - for currently selected file(s).

### Creating quick folder

![SCREENSHOT](https://raw.githubusercontent.com/sjain882/FFMPEG-QTTabBar-Tools/refs/heads/main/Previews/Toolbar.png?raw=true)

<details>
<summary>Expand</summary> 

Right click on toolbar empty space (leftmost/rightmost, not near any buttons) and set options as follows:

![SCREENSHOT](https://raw.githubusercontent.com/sjain882/FFMPEG-QTTabBar-Tools/refs/heads/main/Previews/CBar-Settings.png?raw=true)

Then, repeat that right click and:

1. Add items

2. Add virtual folder

3. Right click on created folder > Edit label > Replace with this blank char: `‎` (U+200E)

4. Right click on created folder > Edit icon > Set to `Icon\Movie128_jpg.ico` (thanks [Icons8](https://icons8.com/icons/set/film-camera--static--white)).

5. Refer to "Usage" above

6. Drag newly created icons into this folder.

7. Repeat toolbar right click and set options as follows, to remove all annoying lines:

![SCREENSHOT](https://raw.githubusercontent.com/sjain882/FFMPEG-QTTabBar-Tools/refs/heads/main/Previews/CBar-Settings2.png?raw=true)
</details>

***

### `QTTB-MP4-Optimizer`

`ffmpeg -i INPUT.mp4 -vcodec libx264 -crf 24 OUTPUT.mp4` from https://unix.stackexchange.com/a/38380

Works in batch if multiple files specified. Best used with h264 .mp4 files from OBS.

![SCREENSHOT](https://raw.githubusercontent.com/sjain882/FFMPEG-QTTabBar-Tools/refs/heads/main/Previews/QTTB-MP4-Optimizer.png?raw=true)

***

### `QTTB-Trimmer`

`ffmpeg -copyts -ss [start] -i INPUT.mp4 -to [end] -map 0 -c copy OUTPUT.mp4` from https://superuser.com/a/377407 (no re-encode)

Some videos can break in telegram desktop + mobile with this method. In those cases, use duration version instead. Fine everywhere else.

![SCREENSHOT](https://raw.githubusercontent.com/sjain882/FFMPEG-QTTabBar-Tools/refs/heads/main/Previews/QTTB-Trimmer.png?raw=true)

***

### `QTTB-Trimmer-Duration`

`ffmpeg -ss [start] -i INPUT.mp4 -t [duration] -map 0 -c copy OUTPUT.mp4` from https://superuser.com/a/377407 (no re-encode)

Works fine with telegram desktop, may still be broken in telegram mobile. Fine everywhere else.

![SCREENSHOT](https://raw.githubusercontent.com/sjain882/FFMPEG-QTTabBar-Tools/refs/heads/main/Previews/QTTB-Trimmer-Duration.png?raw=true)
