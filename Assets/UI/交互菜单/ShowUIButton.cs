using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ShowUIButton : MonoBehaviour
{
    private UIDocument document;
    private VisualElement root;

    [SerializeField]
    private UIDocument blockSelectorDocument;


    void Awake()
    {
        document = this.GetComponent<UIDocument>();
        root = document.rootVisualElement;
    }

    void Start()
    {
        var but = root.Q<Button>("Menu");
        but.RegisterCallback<ClickEvent>(evt =>
                {
                    var container = blockSelectorDocument.rootVisualElement.Q<VisualElement>("Container");
                    container.visible = true;
                });
    }

    void Update()
    {

    }
}
