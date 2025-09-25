using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiodeescena : MonoBehaviour
{
    public void Cambiodeescenario(string cambio) {
        SceneManager.LoadScene(cambio);
    }
}
