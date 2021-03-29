using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickManager : MonoBehaviour
{
    public class OnTickEventArgs : EventArgs
    {
        public int tick;
    }
    public static event EventHandler<OnTickEventArgs> onTick;
    public float TICK_MAX = 1.0f;

    private int tick;
    private float tickTimer;

    private void Awake()
    {
        tick = 0;
    }


    void Update()
    {
        tickTimer += Time.deltaTime;
        if(tickTimer >= TICK_MAX)
        {
            tickTimer -= TICK_MAX;
            tick++;
            if (onTick != null) onTick(this, new OnTickEventArgs { tick = tick});
        }
        
    }
}
