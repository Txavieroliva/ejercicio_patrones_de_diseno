using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SkeletonFactory
{
    public abstract GameObject CreateSkeleton(Vector3 position);
}

public class BasicSkeletonFactory : SkeletonFactory
{
    private GameObject _skeletonPrefab;

    public BasicSkeletonFactory(GameObject skeletonPrefab)
    {
        _skeletonPrefab = skeletonPrefab;
    }

    public override GameObject CreateSkeleton(Vector3 position)
    {
        return Object.Instantiate(_skeletonPrefab, position, Quaternion.identity);
    }
}

