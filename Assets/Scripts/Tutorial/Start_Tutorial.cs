using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Start_Tutorial : MonoBehaviour
{
    [SerializeField] private Text welcome_tutorial_text;
    [SerializeField] private Text tasks_tutorial_text;
    [SerializeField] private string[] tasks_movement = new string[3];
    [SerializeField] private bool[] tasks_complete_movement = new bool[4];
    [SerializeField] private GameObject Potion;
    [SerializeField] private bool task_potion = false;
    [SerializeField] private bool task_movement = true;
    [SerializeField] private GameObject Player_first;
    [SerializeField] private GameObject Player_second;
    [SerializeField] private Vector3 Player_first_vector;
    [SerializeField] private Vector3 Player_second_vector;

    private void Start() {
        StartCoroutine("Welcome_Tutorial");
    }

    private void Update() {
        if (task_movement) {
            task_set_movement();
        }
        if (task_potion) {
            task_movement = false;
            task_set_potion();
        }
    }

    private void task_set_movement() {
        tasks_tutorial_text.text = "Задача: " + tasks_movement[0];
        if (Input.GetAxis("Horizontal") > 0) {
            tasks_complete_movement[0] = true;
        }
        if (Input.GetAxis("Horizontal") < 0) {
            tasks_complete_movement[1] = true;
        }
        if (tasks_complete_movement[0] && tasks_complete_movement[1]) {
            tasks_tutorial_text.text = "Задача: " + tasks_movement[1];
        }

        if (Input.GetAxis("Vertical") > 0) {
            tasks_complete_movement[2] = true;
        }
        if (Input.GetAxis("Vertical") < 0) {
            tasks_complete_movement[3] = true;
        }
        if (tasks_complete_movement[2] && tasks_complete_movement[3]) {
            task_potion = true;
            tasks_tutorial_text.text = "Задача: " + tasks_movement[2];
        }
    }

    private void task_set_potion() {
        Potion.SetActive(true);
    }

    IEnumerator Welcome_Tutorial() {
        welcome_tutorial_text.gameObject.SetActive(true);
        yield return new WaitForSeconds(6f);
        welcome_tutorial_text.gameObject.SetActive(false);
    }
}