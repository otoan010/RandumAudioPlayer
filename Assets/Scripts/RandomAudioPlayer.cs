using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 複数の「AudioSourceを持つゲームオブジェクト」からランダムに選択し、音を鳴らす
public class RandomAudioPlayer : MonoBehaviour
{
    private GameObject[] audioObjects;

    private void Start()
    {
        // タグでAudioSourceを持つゲームオブジェクト(複数)を見つける
        audioObjects = GameObject.FindGameObjectsWithTag("AudioObject");
  
        // ランダムにオブジェクトを選択
            var audioObject = audioObjects[Random.Range(0, audioObjects.Length)];

            // AudioSourceをPlay
            audioObject.GetComponent<AudioSource>().Play();

            // AudioSourceを持つゲームオブジェクトにアタッチしておいたスクリプトからIDを取得する
            var audioSourceId = audioObject.GetComponent<AudioSourceID>().audioSourceID;
            print(audioSourceId);

    }
}