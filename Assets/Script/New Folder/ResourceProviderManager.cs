using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ResourceProviderManager : MonoBehaviour
{
    [Inject]
    private ResourceProvider resourceProvider;
}
