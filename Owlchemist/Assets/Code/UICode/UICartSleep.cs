using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UICartSleep : UITarget
{
    public GameObject insideCartRef;
    public GameObject questStation;
    public GameObject selectCanvas;
    public Canvas sleepScreen;
    public Image fade;
    public Text dayTXT;
    public Text daysLeftTXT;
    public int finalDay;
    bool fadeIn;
    public float fadeTime;
    public float fadeTimeGoal = 3f;
    public Canvas loseScreen;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!closed)
        {
            var tempColor = fade.color;            
            if(fadeIn)
            {               
                if (tempColor.a == 1)
                {
                    if(finalDay - insideCartRef.GetComponent<CartInteraction>().dayCount < 0)
                    {
                        loseScreen.gameObject.SetActive(true);
                    }
                    else
                    {                    
                        dayTXT.gameObject.SetActive(true);
                        daysLeftTXT.gameObject.SetActive(true);
                        fadeTime += Time.deltaTime;
                        if(fadeTime >= fadeTimeGoal)
                        {
                            fadeIn = false;
                            dayTXT.gameObject.SetActive(false);
                            daysLeftTXT.gameObject.SetActive(false);
                            questStation.GetComponent<UICartCanvas>().NewPage();
                            insideCartRef.GetComponent<CartInteraction>().NewDayReset();

                            insideCartRef.GetComponent<CartInteraction>().player.GetComponent<LightComponent>().currentCharges = insideCartRef.GetComponent<CartInteraction>().player.GetComponent<LightComponent>().maxCharges;
                            insideCartRef.GetComponent<CartInteraction>().player.GetComponent<LightComponent>().Reset();

                            insideCartRef.GetComponent<CartInteraction>().player.GetComponent<UIComponent>().torchIndicator.SetImageFillAmount(1, 1f);
                            insideCartRef.GetComponent<CartInteraction>().player.GetComponent<UIComponent>().torchIndicator.SetImageFillAmount(2, 1f);
                            insideCartRef.GetComponent<CartInteraction>().player.GetComponent<UIComponent>().torchIndicator.SetImageFillAmount(3, 1f);

                            insideCartRef.GetComponent<CartInteraction>().player.GetComponent<MovementComponent>().agent.Warp(insideCartRef.GetComponent<CartInteraction>().cartExitPoint.transform.position);
                            insideCartRef.GetComponent<CartInteraction>().player.transform.position = insideCartRef.GetComponent<CartInteraction>().cartExitPoint.transform.position;
                            insideCartRef.GetComponent<CartInteraction>().player.GetComponent<HealthComponent>().RestoreGranularDamageOverTime(300, 0.4f, true);
                            insideCartRef.GetComponent<CartInteraction>().player.GetComponent<HealthComponent>().OnPlayerRessurected();
                            insideCartRef.GetComponent<CartInteraction>().player.GetComponent<UIComponent>().healthIndicator.Reset();
                            insideCartRef.GetComponent<CartInteraction>().player.GetComponent<MovementComponent>().alive = true;
                            //insideCartRef.GetComponent<CartInteraction>().player.GetComponent<HealthComponent>().RestoreGranularDamageOverTime(300f, 1f, true);
                        }
                    }
                }
                else
                {
                    tempColor.a = Mathf.Clamp(tempColor.a + Time.deltaTime, 0f, 1f);
                }
            }
            else
            {
                if (tempColor.a == 0)
                {
                    closed = true;
                    selectCanvas.SetActive(true);
                    sleepScreen.gameObject.SetActive(false);
                }
                else
                {
                    tempColor.a = Mathf.Clamp(tempColor.a - Time.deltaTime, 0f, 1f);
                }
                
            }          
            fade.color = tempColor;
        }
    }
    public override void MyFuction()
    {
        insideCartRef.GetComponent<CartInteraction>().DayTranition();
        closed = false;
        sleepScreen.gameObject.SetActive(true);
        fadeTime = 0;
        dayTXT.text = "Day " + insideCartRef.GetComponent<CartInteraction>().dayCount.ToString();
        daysLeftTXT.text = (finalDay - insideCartRef.GetComponent<CartInteraction>().dayCount).ToString() + " Days Left";
        fadeIn = true;
        selectCanvas.SetActive(false);

        //Refill torch
        //insideCartRef.GetComponent<CartInteraction>().player.GetComponent<UIComponent>().healthIndicator.Reset();
        //insideCartRef.GetComponent<CartInteraction>().player.GetComponent<HealthComponent>().RestoreDamage(1);


        // Refill health, above can't refill because the canvas is inactive in cart
    }    
    public override void CloseUI()
    {
        base.CloseUI();
    }
}
