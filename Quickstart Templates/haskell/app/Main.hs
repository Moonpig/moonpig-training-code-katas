module Main where

import Add 

main :: IO ()
main = putStrLn ("Hello World - " ++ (show $ add 1 2))
