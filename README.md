# BasicBrowser [![Build status](https://ci.appveyor.com/api/projects/status/vk3okvf6qmlpykgx)](https://ci.appveyor.com/project/Walkman100/basicbrowser)
A simple tabbed browser coded in Vb.Net

[![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/Walkman100/Walkman?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

## Screenshot
You can Hold <kbd>Alt</kbd> to move the buttons around on the main interface. To reset, simply restart BasicBrowser.

[![Screenshot][Screenshot]][Screenshot]

  [Screenshot]: http://walkman100.github.io/images/Screenshots/My_Projects/BasicBrowser/MainWindow.png

## Searching from the URL bar
You should be able to search from the URL bar out of the box. If some queries turn into URLs (e.g. `http://test+search/`) instead of your search engines search, use a question mark `?` before the query (e.g. `?test search`).

If this still doesn't work, make sure the `Search in the address bar and the search box on the new tab page` checkbox in the window described below is checked.

## Changing your search engine
Click the menu bar `Tools`, then under `Internet Properties...` select `Manage add-ons...`, then click the `Manage add-ons` button.

In the window that pops up, click the `Search Providers` tab on the left. Here you can select a search provider, then:
- Set it as default
- Remove it
- Enable/disable search suggestions for it (not available in BasicBrowser yet)
- Right-click to move up or down in the listing order

When you are done, click `Close` at the bottom then `OK`.

## Compile requirements
See [CompileInstructions.md](https://github.com/Walkman100/gists/blob/master/CompileInstructions.md)

## Gecko (IE8 alternative)
As of November 2014, the Gecko branch can be found at [Walkman-Mirror/BasicBrowserGecko](https://github.com/Walkman-Mirror/BasicBrowserGecko). The hybrid branch is also there, since it is essentially BasicBrowserGecko with the ability to open IE tabs as well.

## Many thanks to (code borrowed from):
- https://stackoverflow.com/questions/7458607/vb-net-tabcontrol-web-browser
- http://www.dreamincode.net/forums/topic/70491-how-to-make-a-tabbed-webbrowser/
- http://www.dreamincode.net/forums/topic/60702-extending-the-webbrowser/
