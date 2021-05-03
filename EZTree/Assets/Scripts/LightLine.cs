using UnityEngine;
using System.Collections;

// a simple illumination line
public class LightLine : MonoBehaviour
{
    static Bulb[] lights = new Bulb[16];
    static int ix = 0;
    static float setTime;

    private void Start()
    {
        setTime = Time.time + 10000f;  // so it doesn't go off by itself
    }

    public static void Flash(Bulb b)
    {
        lights[ix++] = b;
        setTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // print("time: " + Time.time + " setTime " + setTime);
        if(Time.time > setTime + 1f)
        {
            print("lighting up the line");
            setTime = Time.time + 10000f;    // reset timer
            StartCoroutine(LightUp());
        }
    }

    IEnumerator LightUp()
    {
        foreach(Bulb b in lights)
        {
            if (b == null)
                break;

            print("next bulb " + b);
            b.Flash();
            yield return new WaitForSeconds(1f);
        }
        // reset
        lights = new Bulb[16];
        ix = 0;
    }
}
