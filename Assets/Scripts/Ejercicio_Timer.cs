using UnityEngine;

public class Ejercicio_Timer : MonoBehaviour
{
    private float tiempoTimer = 0f;
    private float tiempoRegresivo = 0f;

    private int segundos = 0;
    private int duracion = 10;
    private int segundosRestantes = 10;

    private bool timerTerminado = false;
    private bool regresivaTerminada = false;

    void Update()
    {
        LogicaTimer();
        LogicaCuentaRegresiva();
    }

    void LogicaTimer()
    {
        if (timerTerminado) return;

        tiempoTimer += Time.deltaTime;

        if (tiempoTimer >= 1f)
        {
            segundos++;
            Debug.Log("Segundo: " + segundos);
            tiempoTimer = 0f;

            if (segundos >= duracion)
            {
                timerTerminado = true;
                Debug.Log("Timer Terminado");
            }
        }
    }

    void LogicaCuentaRegresiva()
    {
        if (regresivaTerminada) return;

        tiempoRegresivo += Time.deltaTime;

        if (tiempoRegresivo >= 1f)
        {
            segundosRestantes--;
            Debug.Log("Tiempo restante: " + segundosRestantes);
            tiempoRegresivo = 0f;

            if (segundosRestantes <= 0)
            {
                regresivaTerminada = true;
                Debug.Log("Cuenta Regresiva Terminada");
            }
        }
    }
}