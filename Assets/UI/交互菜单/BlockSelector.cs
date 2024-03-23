using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BlockSelector : MonoBehaviour
{

    private UIDocument document;
    private VisualElement root;

    void Start()
    {
        document = this.GetComponent<UIDocument>();
        root = document.rootVisualElement;
        var but = root.Q<Button>("CloseButton");
        but.RegisterCallback<ClickEvent>(evt =>
                {
                    var container = root.Q<VisualElement>("Container");
                    container.visible = false;
                });
    }


    void Update()
    {

    }
}
