{-# LANGUAGE ScopedTypeVariables #-}
module ExampleSpec where

import Test.Hspec
import Test.QuickCheck

import Add

spec :: Spec
spec = describe "ExampleSpec" $ do 
    context "Addition" $ do 
        it "should add 2 number" $
            add 1 2 `shouldBe` 3
        it "should be commutative" $
            property $ \(x :: Int, y :: Int) -> add x y `shouldBe` add y x
