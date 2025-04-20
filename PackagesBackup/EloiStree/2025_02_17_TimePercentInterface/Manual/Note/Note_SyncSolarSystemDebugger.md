
If you are creating NTP-based games,  
you will need to check if the game is synchronized.  

One game syncs every 1 minute.  
Another syncs every 22 minutes.  
The third syncs based on a percentage, given a manually managed non-NTP game.  

To avoid having to create links in all directions,  

two static classes can be created:  
- `PctTimeMono_ListenToStaticGameTimePercent`  
- `PctTimeMono_ListenToStaticNtpMillisecondsOffset`  

As you might guess, to push data, use:  
- `PctTimeMono_PushToStaticGameTimePercent`  
- `PctTimeMono_PushToStaticNtpMillisecondsOffset`  

The demo shows that if you have:
- an NTP offset  
- a fixed game start time  

you can keep the game synchronized by time — forever.  
You just need to never change the game time reference.  

I use **1970 UTC in milliseconds** as the start point.

