import { FC } from "react";
import { Route, Routes } from "react-router-dom";
import { Layout } from "./components/layout";
import { GoodsView } from "./components/views/goods";
import { SignView } from "./components/views/sign";

export const App: FC = () => {
  return (
    <div className="h-full flex flex-col">
      <Layout.Header />
      <main className="flex-1 container mx-auto">
        <Routes>
          <Route path="/goods" element={<GoodsView />} />
          <Route path="/sign" element={<SignView />} />
        </Routes>
      </main>
      <footer className="h-16 container mx-auto">
      </footer>
    </div>
  );
}
