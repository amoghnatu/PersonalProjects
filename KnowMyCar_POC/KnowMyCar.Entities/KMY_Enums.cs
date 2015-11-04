using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowMyCar.Entities
{
    public enum CarType
    {
        HatchBack=1,
        Sedan,
        SUV
    }

    public enum CarClass
    {
        Economy=1,
        MidRange,
        Sports,
        Luxury,
        OffRoader
    }

    public enum StarRating
    {
        OneStar=1,
        TwoStars,
        ThreeStars,
        FourStars,
        FiveStars
    }

    public enum RatingLevel
    {
        Poor=1,
        BelowAverage,
        Average,
        Good,
        Best
    }

    public enum CarFuelVariant
    {
        Diesel,
        Petrol,
        CNG,
        Hybrid,
        FullyElectric
    }
}
