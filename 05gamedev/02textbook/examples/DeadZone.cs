using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

    public GameObject ExplotionParticle;

    void OnTriggerEnter(Collider otherObject)
    {
        // сохраним себе трансформ объекта который попал в триггер
        // это сделано  только что бы писать меньше кода внизу
        Transform otherTransform = otherObject.transform;
        Vector3 EffectPosition = otherTransform.position
            + otherTransform.forward;

        // зачем сохраняю объект в переменную?
        // я хочу удалить его спустя какое-то время, 
        // что бы не замнимать ресурсы компа
        GameObject spawnedEffect = Instantiate
            (
                ExplotionParticle,
                EffectPosition,
                Quaternion.identity
            );

        Destroy(spawnedEffect, 5f);
    }
}
