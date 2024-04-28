// Script Convertie par Eshaetti avec un sample de trajet Retn fait par Melionor

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Retn.Game;
using Retn.Game.Pathing;
using Retn.Game.Script;
using Retn.Protocol.Game.Enums;

namespace Retn.Script;

public class sample(IScript script)
{
    private IScriptArena Arena => script.Arena;
    private IScriptBank Bank => script.Bank;
    private IScriptCharacter Character => script.Character;
    private IScriptChat Chat => script.Chat;
    private IScriptCommon Common => script.Common;
    private IScriptCraft Craft => script.Craft;
    private IScriptData Data => script.Data;
    private IScriptExchange Exchange => script.Exchange;
    private IScriptExchangeSale ExchangeSale => script.ExchangeSale;
    private IScriptFight Fight => script.Fight;
    private IScriptHunt Hunt => script.Hunt;
    private IScriptInventory Inventory => script.Inventory;
    private IScriptJob Job => script.Job;
    private IScriptMap Map => script.Map;
    private IScriptMount Mount => script.Mount;
    private IScriptNpc Npc => script.Npc;
    private IScriptQuest Quest => script.Quest;

   [Handler]
   public Task OnLoadedAsync()
   {
      Bank.SetWeightLimit(85, 95);

      return Task.CompletedTask;
   }


   [Handler]
   public async Task OnMoveAsync(int count)
   {
      var items = Inventory.GetItems([00000]); // OpenBag à remplir pour un trajet récolte

      foreach(var item in items)
      {
         await Inventory.UseAsync(item, item.Quantity);
      }

      await script.Map.GatherAsync([000, 111, 222, 333]); // Ligne à conserver pour activer la récolte ( ajuster les id en fonction )
                                                         // ou à commenter pour un trajet sans récolte ou un trajet fight par exemple à votre convenance.
      var move1 = new Dictionary < long,
         List < Func < Task >>>
         {

         };

      if (move1.TryGetValue(Map.Id, out
            var actions1))
      {
         await actions1[(count - 1) % actions1.Count]();
         return;
      }

      var move = new Dictionary < (short, short),
         List < Func < Task >>>
         {
            [(0, 0)] = [
               async () =>
               {
                  await Map.UseZaapAsync(0000000); // Zaap à remplir
               },
            ],

[(-78,-41)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-79,-41)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-80,-41)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-81,-41)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-82,-41)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-82,-42)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-82,-43)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-81,-43)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-81,-44)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-82,-44)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-83,-44)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-84,-44)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-85,-44)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-85,-45)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-85,-46)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-85,-47)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-84,-47)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-83,-47)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-82,-47)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-82,-48)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-81,-48)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-80,-48)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-79,-48)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-79,-47)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-78,-47)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-77,-47)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-76,-47)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-75,-47)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-74,-47)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-73,-47)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-73,-48)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-73,-49)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-73,-50)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-73,-51)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-73,-52)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-73,-53)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-72,-53)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-70,-56)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-69,-56)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-68,-56)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-67,-56)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-67,-57)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-67,-58)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-67,-59)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-66,-59)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-65,-59)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-64,-59)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-63,-59)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-63,-60)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-62,-60)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-61,-60)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-60,-60)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-60,-61)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-60,-62)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-60,-63)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-59,-63)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-59,-64)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-59,-65)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-59,-66)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-58,-66)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-57,-66)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-57,-65)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-57,-64)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-57,-63)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-58,-63)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-58,-62)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-58,-61)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-58,-60)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-57,-60)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-56,-60)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-55,-60)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-55,-59)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-56,-59)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-57,-59)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-57,-58)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-57,-57)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-58,-57)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-58,-56)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-59,-56)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-60,-56)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-60,-55)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-60,-54)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-60,-53)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-60,-52)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-60,-51)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-61,-51)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(-71,-55)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-71,-56)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-71,-54)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-71,-53)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],



         };

      if (move.TryGetValue(Map.Coords, out
            var actions))
      {
         await actions[(count - 1) % actions.Count]();
         return;
      }

      await Map.GoToHavenBagAsync();
   }
    [Handler]
   public async Task OnMoveBankAsync()
   {
      if (Map.Id == 214696968)
      {
         await Npc.SpeakToAsync(6374);
         return;
      }

      switch (Map.Coords)
      {
         case (0, 0):
            await Map.UseZaapAsync(212861955); // Zaap Brakmar
            break;
         case (-26, 37):
         case (-26, 36):
            await Map.AutoTripAsync(214696968); // Intérieur Banque Brakmar
            break;
         default:
            await Map.GoToHavenBagAsync();
            break;
      }
   }

   [Handler]
   public async Task OnNpcDialogOpenedAsync(NpcQuestion question)
   {
      if (question.MessageId == 47040)
      {
         await Npc.AnswerAsync(question.Replies[0]);
      }
   }

   [Handler]
   public async Task OnBankOpenedAsync()
   {
      await Bank.DepositAsync(DepositType.Resources); // Resources pour déposer uniquement ces dernière au Everything pour tout déposer.

      await Bank.TakeKamasAsync(Bank.Kamas);

      await Bank.LeaveAsync();
   }

   [Handler]
   public async Task OnFightPosAsync()
   {
      await Fight.SetBonusAsync(ChallengeBonusEnum.ChallengeDropBonus);

      await Fight.SetPositionAsync(FightPosition.Furthest);
   }

   [Handler]
   public async Task OnFightTurnAsync()
   {
      switch (Character.Breed)
      {
         case PlayableBreedEnum.Ecaflip:

            await Fight.ExecuteAsync(
               [
                  new FightActionMove(FightMove.Nearest), // Déplacement
                  new FightActionCast(12869, CastTarget.Invoke), // Caresse  Invocatrice
                  new FightActionCast(12850, CastTarget.Me), // Contrecoup
                  new FightActionCast(12845, CastTarget.Me), // Roue de la Fortune 
                  new FightActionCast(12841, CastTarget.Enemy), // Pile Ou Face
                  new FightActionCast(12841, CastTarget.Enemy), // Pile Ou Face
                  new FightActionFinishTurn() // Passe
               ]);

            break;

         case PlayableBreedEnum.Sadida:

            await Fight.ExecuteAsync(
               [
                  new FightActionMove(FightMove.Nearest), // Déplacement
                  new FightActionCast(13564, CastTarget.Invoke), // Folle
                  new FightActionCast(13516, CastTarget.Enemy), // Ronce
                  new FightActionCast(13516, CastTarget.Enemy), // Ronce
                  new FightActionFinishTurn() // Passe
               ]);

            break;

         case PlayableBreedEnum.Feca:

            await Fight.ExecuteAsync(
               [
                  new FightActionMove(FightMove.Nearest), // Déplacement
                  new FightActionCast(12981, CastTarget.Me), // Rempart
                  new FightActionCast(13007, CastTarget.Enemy), // Houlette
                  new FightActionCast(12993, CastTarget.Enemy), // Lethargie
                  new FightActionCast(12978, CastTarget.Enemy), // Langueur
                  new FightActionFinishTurn() // Passe
               ]);

            break;

         case PlayableBreedEnum.Sacrieur:

            await Fight.ExecuteAsync(
               [
                    new FightActionMove(FightMove.Nearest),
                    new FightActionCast(12744, CastTarget.Invoke), // Épée Vorace
                    new FightActionCast(12746, CastTarget.Enemy), // Ravage
                    new FightActionCast(12725, CastTarget.Enemy), // Supplice
                    new FightActionCast(12725, CastTarget.Enemy), // Supplice
                    new FightActionFinishTurn()
               ]);

            break;

         case PlayableBreedEnum.Enutrof:

            await Fight.ExecuteAsync(
               [
                  new FightActionMove(FightMove.Nearest), // Déplacement
                  new FightActionCast(13328, CastTarget.Invoke), // Sac Animé
                  new FightActionCast(13338, CastTarget.Enemy), // Lancer de Pièces
                  new FightActionCast(13338, CastTarget.Enemy), // Lancer de Pièces
                  new FightActionFinishTurn() // Passe
               ]);

            break;
      }
   }

   [Handler]
   public Task OnInventoryWeightChangedAsync()
   {
      if (Character.IsInBank)
      {
         Bank.SetWeightLimit(85, 95);
      }

      return Task.CompletedTask;
   }
}