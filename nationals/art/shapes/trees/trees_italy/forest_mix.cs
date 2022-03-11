
singleton TSShapeConstructor(Forest_mixDae)
{
   baseShape = "./forest_mix.dae";
};

function Forest_mixDae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "256", "1", "0");
}
