using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour {

    [HideInInspector] public static PoolManager instance = null;

    [SerializeField]
    private PrefabPool IndicatorTag;
    [SerializeField]
    private PrefabPool Explosion;
    [SerializeField]
    private PrefabPool RocketThrust;
    [SerializeField]
    private PrefabPool ImpactPuff;
    [SerializeField]
    private PrefabPool IndicatorArrow;
    [SerializeField]
    private PrefabPool WadingAnim;
    [SerializeField]
    private PrefabPool Shadow;
    [SerializeField]
    private PrefabPool CeilingDitherMask;
    [SerializeField]
    private PrefabPool PlayerPool;
    [SerializeField]
    private PrefabPool ConfettiPool;
    [SerializeField]
    private PrefabPool SplashPool;
    [SerializeField]
    private PrefabPool TrailPool;
    [SerializeField]
    private PrefabPool FireballPool;
    [SerializeField]
    private PrefabPool StegoSwingFXPool;
    [SerializeField]
    private PrefabPool DoorSlideFXPool;
    [SerializeField]
    private PrefabPool DustPuffFXPool;
    [SerializeField]
    private PrefabPool SpaceSuckFXPool;
    [SerializeField]
    private PrefabPool VacuumFXPool;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public GameObject GetPickupIndicatorTag()
    {
        return IndicatorTag.GetObject();
    }

    public void ReturnPickupIndicatorTag(GameObject obj)
    {
        IndicatorTag.ReturnObject(obj); 
    }

    public GameObject GetExplosion()
    {
        return Explosion.GetObject();
    }

    public void ReturnExplosion(GameObject obj)
    {
        Explosion.ReturnObject(obj);
    }

    public GameObject GetThrust()
    {
        return RocketThrust.GetObject();
    }

    public void ReturnThrust(GameObject obj)
    {
        RocketThrust.ReturnObject(obj);
    }

    public GameObject GetImpactPuff()
    {
        return ImpactPuff.GetObject();
    }

    public void ReturnImpactPuff(GameObject obj)
    {
        ImpactPuff.ReturnObject(obj);
    }

    public GameObject GetIndicatorArrow()
    {
        return IndicatorArrow.GetObject();
    }

    public void ReturnIndicatorArrow(GameObject obj)
    {
        IndicatorArrow.ReturnObject(obj);
    }

    public GameObject GetWadingAnim()
    {
        return WadingAnim.GetObject();
    }

    public void ReturnWadingAnim(GameObject obj)
    {
        WadingAnim.ReturnObject(obj);
    }

    public GameObject GetShadow()
    {
        return Shadow.GetObject();
    }

    public void ReturnShadow(GameObject obj)
    {
        Shadow.ReturnObject(obj);
    }

    public GameObject GetCeilingDitherMask()
    {
        return CeilingDitherMask.GetObject();
    }

    public void ReturnCeilingDitherMask(GameObject obj)
    {
        CeilingDitherMask.ReturnObject(obj);
    }

    public GameObject GetPlayer()
    {
        return PlayerPool.GetObject();
    }

    public void ReturnPlayer(GameObject obj)
    {
        PlayerPool.ReturnObject(obj);
    }

    public GameObject GetConfetti()
    {
        return ConfettiPool.GetObject();
    }

    public void ReturnConfetti(GameObject obj)
    {
        ConfettiPool.ReturnObject(obj);
    }

    public GameObject GetSplash()
    {
        return SplashPool.GetObject();
    }

    public void ReturnSplash(GameObject obj)
    {
        SplashPool.ReturnObject(obj);
    }

    public GameObject GetTrail()
    {
        return TrailPool.GetObject();
    }

    public void ReturnTrail(GameObject obj)
    {
        TrailPool.ReturnObject(obj);
    }

    public GameObject GetFireball()
    {
        return FireballPool.GetObject();
    }

    public void ReturnFireball(GameObject obj)
    {
        FireballPool.ReturnObject(obj);
    }

    public GameObject GetStegoSwingFX()
    {
        return StegoSwingFXPool.GetObject();
    }

    public void ReturnStegoSwingFX(GameObject obj)
    {
        StegoSwingFXPool.ReturnObject(obj);
    }    

    public GameObject GetDoorSlideFX()
    {
        return DoorSlideFXPool.GetObject();
    }

    public void ReturnDoorSlideFX(GameObject obj)
    {
        DoorSlideFXPool.ReturnObject(obj);
    }

    public GameObject GetDustPuffFX()
    {
        return DustPuffFXPool.GetObject();
    }

    public void ReturnDustPuffFX(GameObject obj)
    {
        DustPuffFXPool.ReturnObject(obj);
    }

    public GameObject GetSpaceSuckFX()
    {
        return SpaceSuckFXPool.GetObject();
    }

    public void ReturnSpaceSuckFX(GameObject obj)
    {
        SpaceSuckFXPool.ReturnObject(obj);
    }

    public GameObject GetVacuumFX()
    {
        return VacuumFXPool.GetObject();
    }

    public void ReturnVacuumFX(GameObject obj)
    {
        VacuumFXPool.ReturnObject(obj);
    }

}


